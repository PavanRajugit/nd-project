**CodingTest.UI – CSV Viewer**

A simple Windows Forms application that loads a CSV file into a table, shows the value of a cell on double-click, and logs all errors to a text file on the Desktop.

**Overview**

The application:

Loads a CSV file included in the project.

Displays the data in a DataGridView.

Opens a popup window showing the clicked cell value.

Logs any errors to a Desktop log file.

Runs immediately after cloning with no extra setup.

**Folder Structure**
Forms/            MainForm and CellValueForm
Services/         CsvService and LoggerService
Resources/        sample.csv
Program.cs        Application entry point

**How to Set Up**

Clone the repository.

Open CodingTest.UI.sln in Visual Studio.

Ensure sample.csv has properties:

Build Action: Content

Copy to Output Directory: Copy Always

Build and run the solution.

**How to Use**

Launch the application.

The CSV loads automatically into the table.

Double-click any cell to view its value in a popup.

Check the Desktop for CodingTest_Log.txt if errors occur.

**Requirements Covered**

CSV loading

Grid display

Double-click popup
