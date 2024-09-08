namespace CvMaker

open CvMaker.CommonTypes
open Microsoft.Playwright

type PdfGenerator() =
    member this.Generate(html: string) =
        async {
            use! playwright = Playwright.CreateAsync() |> Async.AwaitTask
            let! browser = playwright.Chromium.LaunchAsync(BrowserTypeLaunchOptions(Headless = true)) |> Async.AwaitTask
            let! page = browser.NewPageAsync() |> Async.AwaitTask

            do! page.SetContentAsync(html) |> Async.AwaitTask
            let! _ = page.PdfAsync(PagePdfOptions(Format = "A4", Path = "./cv.pdf")) |> Async.AwaitTask

            // Close the page
            do! page.CloseAsync() |> Async.AwaitTask
        }
        
    member this.Generate(applicant: Applicant) =
        raise (System.NotImplementedException("Noooo"))