# UML Class Diagram – Ultimate Generator App

```mermaid
classDiagram
    %% Main application entry point
    class Program {
        +Main(string[] args)
        -GeneratePasswordFlow()
        -TestPasswordFlow()
        -GenerateFictionalNameFlow()
        -GenerateGeographicalNameFlow()
        -GenerateStoryPlotFlow()
    }

    %% Data persistence
    class DataManager {
        +SavePassword(string)
        +LoadPasswords()
        +SaveFictionalName(FictionalName)
        +LoadFictionalNames()
        +SaveGeoName(GeoName)
        +LoadGeoNames()
        +SaveStoryPlot(StoryPlot)
        +LoadStoryPlots()
    }

    %% Generators
    class PasswordGenerator {
        +Length : int
        +UpperCaseCount : int
        +NumberCount : int
        +SpecialCharCount : int
        +Generate() string
    }

    class FictionalNameGenerator {
        +GenerateName() string
    }

    class GeoNameGenerator {
        +GenerateName() string
    }

    class StoryPlotGenerator {
        +GeneratePlot() string
    }

    %% Validator
    class PasswordValidator {
        +EvaluateStrength(password : string) string
    }

    %% Models
    class FictionalName {
        +Name : string
        +CreatedAt : DateTime
    }

    class GeoName {
        +Name : string
        +CreatedAt : DateTime
    }

    class StoryPlot {
        +Plot : string
        +CreatedAt : DateTime
    }

    %% Relationships
    Program --> PasswordGenerator
    Program --> PasswordValidator
    Program --> FictionalNameGenerator
    Program --> GeoNameGenerator
    Program --> StoryPlotGenerator
    Program --> DataManager

    DataManager --> FictionalName
    DataManager --> GeoName
    DataManager --> StoryPlot
    DataManager --> PasswordGenerator

    PasswordGenerator ..> DataManager
