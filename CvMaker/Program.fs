namespace CvMaker

module Main =

    //let _ = Microsoft.Playwright.Program.Main([| "install" |]) // Used to install dependencies

    async {
        let applicant = DataStore.getAwesomeApplicant
    
        let html = CvHtmlGenerator.generate applicant         
       
        let pdfGenerator = PdfGenerator()
        do! pdfGenerator.Generate(html)
        
    } |> Async.RunSynchronously