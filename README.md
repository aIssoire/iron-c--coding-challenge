# PhonePadTranslator Project

## Description

This project contains an implementation of a translator for an old phone keypad and a set of unit tests to verify its functionality. The main project is `IronCodingChallenge`, and the test project is `IronCodingChallengeTests`.

## Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download)
- [Git](https://git-scm.com/)

## Installation

1. Clone this repository to your local machine:
    ```bash
    git clone git@github.com:aIssoire/iron-c--coding-challenge.git
    cd iron-c--coding-challenge
    ```

2. Restore the necessary packages for both projects:
    ```bash
    cd IronCodingChallenge
    dotnet restore
    cd ../IronCodingChallengeTests
    dotnet restore
    ```

## Project Structure

- `IronCodingChallenge`: The main project containing the implementation of the phone keypad translator.
    - `IronCodingChallenge.csproj`: Project file for the main project.
    - `Program.cs`: Main program file.
- `IronCodingChallengeTests`: The test project containing unit tests for the `PhonePadTranslator`.
    - `IronCodingChallengeTests.csproj`: Project file for the test project.
    - `UnitTest1.cs`: Contains the unit tests.
    - `Usings.cs`: Contains the global using directives.

## Running the Tests

To run the tests with detailed output in the console, follow these steps:

1. Navigate to the test project directory:
    ```bash
    cd IronCodingChallengeTests
    ```

2. Run the tests with detailed output:
    ```bash
    dotnet test --logger "console;verbosity=detailed"
    ```

This command will display the test results in detail, including passed tests, failed tests, and associated error messages.

## Example Output

Here is an example of what the output might look like after running the above command:

```plaintext
Build started, please wait...
Build completed.

Test run for /path/to/IronCodingChallengeTests/bin/Debug/net7.0/IronCodingChallengeTests.dll (.NETCoreApp,Version=v7.0)
Microsoft (R) Test Execution Command Line Tool Version 16.6.1
Copyright (c) Microsoft Corporation. All rights reserved.

Starting test execution, please wait...
[...]
Passed TestSingleLetterE [1 ms]
Passed TestSingleLetterB [1 ms]
Passed TestWordHELLO [2 ms]
Passed TestCharactersWithSpacesAndMultipleKeys [2 ms]
Passed TestWordZOEJ [1 ms]
Passed TestSingleLetterC [1 ms]
Passed TestLettersACWithSpace [1 ms]
Passed TestLettersAD [1 ms]
Passed TestSpaceCharacter [1 ms]
Total tests: 9. Passed: 9. Failed: 0. Skipped: 0.
Test Run Successful.
Test execution time: 2.3456 Seconds
