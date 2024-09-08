namespace CvMaker.UnitTest

open NUnit.Framework
open FsUnit
open CvMaker.CommonTypes
open CvMaker.CvHtmlGenerator

[<TestFixture>]
type CvHtmlGeneratorTests() =
    
    [<Test>]
    member this.``Generate CV should create correct HTML structure``() =
        // Arrange
        let applicant = {
            Name = "John Doe"
            Title = "Software Developer"
            PhoneNumber = "1234567890"
            Email = "johndoe@example.com"
            Birthyear = 2020 
            Experiences = [
                { Company = "Company A"; Title = "Developer"; Period = "2018-2020"; Location = "New York" }
                { Company = "Company B"; Title = "Senior Developer"; Period = "2020-2023"; Location = "San Francisco" }
            ]
            BuzzWords = [
             "Agile"
             "Cloud"
             "DevOps"
            ]
        }

        // Act
        let resultHtml = generate applicant

        // Assert
        resultHtml |> should contain "John Doe&#39;s CV"
        resultHtml |> should contain "<h1>John Doe</h1>"
        resultHtml |> should contain "<h2>Software Developer</h2>"
        resultHtml |> should contain "<p>Phone: 1234567890</p>"
        resultHtml |> should contain """<a href="mailto:johndoe@example.com">johndoe@example.com</a>"""
        resultHtml |> should contain "<div class=\"tag\">Agile</div>"
        resultHtml |> should contain "<div class=\"tag\">Cloud</div>"
        resultHtml |> should contain "<div class=\"tag\">DevOps</div>"
        resultHtml |> should contain "<tr><td>Company A</td><td>Developer</td><td>2018-2020</td><td>New York</td></tr>"
        resultHtml |> should contain "<tr><td>Company B</td><td>Senior Developer</td><td>2020-2023</td><td>San Francisco</td></tr>"
