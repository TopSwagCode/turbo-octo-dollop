namespace CvMaker.IntegrationTest

open System
open System.IO
open System.Threading.Tasks
open NUnit.Framework
open FsUnit

[<TestFixture>]
type PdfGeneratorTests() =
    let pdfPath = "./cv.pdf"
    
    [<Test>]
    member this.``Generate should create CV file``() =
        // Arrange
        let htmlContent = "<html><body><h1>Test CV</h1></body></html>"
        let pdfGenerator = CvMaker.PdfGenerator()
        
        // Act
        let task = pdfGenerator.Generate(htmlContent) |> Async.StartAsTask
        Task.WaitAll(task)

        // Assert
        File.Exists(pdfPath) |> should equal true
            
    [<TearDown>]
    member _.Cleanup() =
        if File.Exists(pdfPath) then
            File.Delete(pdfPath)