# Comma Chamelion

This is a test program for Microsoft DotNet 3.0 SDK. It should work on Linux, MacOS, and MS Windows.

Where to get the DotNet 3.0 SDK:  https://github.com/dotnet/core-sdk

You do not have to upgrade your DotNet SDK if you download the dotnet-sdk-latest.zip file and extract it. Use the command line to build/run the program like:

`C:/path/to/dotnet> dotnet run`

from the command line where the project is the current directory.

## Usage

Comma Chamelion is a swiss army knife -style program for doing several different things.

Copy/Paste into the upper text box, one item per line. Click the button on the right and the output will appear in the bottom text box.

### Prerequisites

DotNet 3.00 runtime or SDK

## Capabilities

* Copy/Paste

    **Copy** button copies the text from the Output text box to the Windows Clipboard.

    **Clear** button clears *both* the input and the output textboxes.

* List Operations

    **Sort** sort the contents of the input text box.

    **Comma** Convert a list of whatevers to a single line delimited by the comma character

    *If the Delimiter check box is clicked you get items in double-quotes*

* Generate SQL
    
    **Tables** Create SQL tables with default fields. Special handling for *cfg* and *lst* tables.
    
    **Proc Drop** Drop Stored Procedures if they exist

    **Table Drop** Drop Tables if they exist

    **View Drop** Drop Views if they exist

    **SQL Vanity** Create a SQL Vanity header including who wrote it, what the purpose of the thing is, creation and updated dates.

* and there is an **EXIT** button