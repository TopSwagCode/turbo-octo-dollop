namespace CvMaker

module Main =
    async {
        let applicant = DataStore.getAwesomeApplicant
    
        let html = CvHtmlGenerator.generate applicant         
       
        let pdfGenerator = PdfGenerator()
        do! pdfGenerator.Generate(html)
        
    } |> Async.RunSynchronously