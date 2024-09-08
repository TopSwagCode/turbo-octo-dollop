namespace CvMaker

module CommonTypes =
    type Experience = {
        Company: string
        Title: string
        Period: string
        Location: string
    }
    type Address = { Test: string }
    type Applicant = { Name: string; Title: string; Birthyear: int; Email: string; PhoneNumber: string; Experiences: List<Experience>; BuzzWords: List<string>; Skills: List<string>}