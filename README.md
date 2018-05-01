SampleAddin created with Addin-Express.

Minimal viable example
for "Error: Could not complete the operation due to error 8150002e"

Code related to the issue:
* SDXOLForm1.cs (navigates the browser to SamplePage.HTML hosted on localhost:8001)
* SamplePage.HTML (contains a button, which calls window.open function).

In some machines, after clicking the button following exception comes up.
"Error: Could not complete the operation due to error 8150002e"
