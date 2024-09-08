namespace CvMaker

module DataStore =
    open CommonTypes
    let getAwesomeApplicant =
        let experiences: List<Experience> = [
            { Company = "iPaper"; Title = "Senior Software Engineering"; Period = "February 2023 - Present"; Location = "Midtjylland, Denmark" }
            { Company = "A.P. Moller - Maersk"; Title = "Senior Software Developer"; Period = "December 2021 - February 2023 (1 year 3 months)"; Location = "Copenhagen" }
            { Company = "BRØLSTÆRK"; Title = "Senior Software Developer"; Period = "September 2019 - December 2021 (2 years 4 months)"; Location = "Lystrup, Middle Jutland, Denmark" }
            { Company = "First Agenda"; Title = "Senior Software Engineer"; Period = "November 2016 - September 2019 (2 years 11 months)"; Location = "Århus Area, Denmark" }
            { Company = "Wallmob"; Title = "Senior Software Developer"; Period = "August 2016 - November 2016 (4 months)"; Location = "Vejle" }
            { Company = "Stibo Systems"; Title = "Quality Assurance Engineer"; Period = "September 2014 - August 2016 (2 years)"; Location = "Århus Area, Denmark" }
            { Company = "Novicell"; Title = "Software Developer"; Period = "August 2011 - August 2013 (2 years 1 month)"; Location = "Århus Area, Denmark" }
        ]
        
        let buzzWords: List<string> = [
            "Scrum"
            "eXtreme Programming"
            "Agile"
            "Test Driven Development"
            "Distributed systems"
            "Domain Driven Design"
            "CI CD"
            "Hexagonal architecture"
            "Lean Management / Development"
            "Kanban"
            "Testing (Pairwise, Exploratory / Tours)"
            "SOA"
            "SAFe"
            "MVC"
            "Jamstack"
            "System Integration"
            "Large Systems / Scalability"
            "Databases"
            "Testing"
            "Security"
            "OIDC"
            "OAuth2"
            "Authentication"
            "Authorization"
        ]
        
        let skills = [
            "C#"
            "ASP.NET"
            "Dotnet Core"
            "Dotnet"
            "Dotnet Framework"
            "Docker"
            "MSMQ"
            "RabbitMQ"
            "SQS"
            "SNS"
            "Razor"
            "Entity Framework"
            "SQL"
            "Java"
            "HTML5"
            "JavaScript"
            "Svelte"
            "CSS"
            "Visual Studio"
            "Rider"
            "Open Telemetry"
            "Git"
            "Jira"
            "Azure"
            "AWS"
        ]
        
        { Name = "Joshua Jesper Krægpøth Ryder"; Title = "Senior Software Engineer"; Birthyear = 1987; Email = "Josh@topswagcode.com"; PhoneNumber = "88888888"; Experiences = experiences; BuzzWords = buzzWords; Skills = skills }