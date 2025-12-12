# CodingTest.UI

Overview
A WinForms app that loads `Resources/sample.csv` into a DataGridView, opens a dialog showing a cell value on double-click, and logs errors to `CodingTest_Log.txt` on the Desktop.

Build & Run
1. Open the solution in Visual Studio (2022/2026).
2. If you modified the `.csproj` externally, right?click the project ? __Reload Project__.
3. Build: __Build > Rebuild Solution__ (or __Clean Solution__ then __Rebuild Solution__).
4. Run (F5). Double?click any cell to open the cell value dialog.

Notes
- `Resources/sample.csv` must be included in the project as Content with `<CopyToOutputDirectory>Always</CopyToOutputDirectory>`.
- Log file: `CodingTest_Log.txt` on the Desktop.
- Ensure all `.Designer.cs` and `.resx` files are committed so the project builds without designer regeneration.

Submission
- Commit and push all files to GitHub and send the repo link to the requested email.