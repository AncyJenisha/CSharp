# DATA ACQUISITION SYSTEM
## Milestones:
commit 1 : Data Acquisition Module.
    Setting Configuration limit in JSON.
    Loading the JSON file and generating data within the range.
Commit 2 : Data Acquisition module.
    Get Compilance data from the user.
    Check if the data is within limits (Compilance Logic).
Commit 3 : Main Console.
    Refreshing on changing the configuration file.
    The menu and display log features.
    Logging the error.

## Class Structure
ConfiguredData -  Has the parameters and thier maximum, minimum values as fields.

DataAcquisitor - Has the methods to generate data based on the loaded data from the configuration file and refresh the generation when there is updation in the configuration file.

Logger - Has method to log the error.

ConfigurationInitializer - Has methods to set configuration, load the configuration file.

ComplianceInitializer - Has methods to set the compliance data.

Main - Displays the options and calls the methods based on the user choice.