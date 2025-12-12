using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using CodingTest.UI.Services;

namespace CodingTest.UI
{
    public partial class MainForm : Form
    {
        private readonly LoggerService _logger;
        private readonly CsvService _csvService;

        public MainForm()
        {
            InitializeComponent();
            _logger = new LoggerService();
            _csvService = new CsvService(_logger);

            // wire load if designer didn't
            this.Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                string csvPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "sample.csv");
                if (!File.Exists(csvPath))
                {
                    // Also try root (some projects copy without folder)
                    csvPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "sample.csv");
                }

                var rows = _csvService.LoadCsv(csvPath);
                if (rows == null || rows.Count == 0)
                    return;

                // Determine max columns
                int maxCols = rows.Max(r => r.Count);

                dataGridView1.Columns.Clear();
                for (int c = 0; c < maxCols; c++)
                {
                    dataGridView1.Columns.Add($"col{c}", $"Column {c + 1}");
                }

                foreach (var row in rows)
                {
                    var values = new object[maxCols];
                    for (int i = 0; i < maxCols; i++)
                        values[i] = i < row.Count ? row[i] : string.Empty;

                    dataGridView1.Rows.Add(values);
                }

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                _logger.LogError("Error initializing MainForm: " + ex);
                MessageBox.Show("An error occurred while loading data. See log on the Desktop.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0 || e.ColumnIndex < 0)
                    return;

                var value = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString() ?? string.Empty;
                using (var dialog = new CellValueForm(value))
                {
                    dialog.ShowDialog(this);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError("Error handling cell double click: " + ex);
                MessageBox.Show("An error occurred. See log on the Desktop.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
