namespace CvMaker

module CvHtmlGenerator =
    open CvMaker.CommonTypes
    open Giraffe.ViewEngine

    let generate (applicant: Applicant) =
        html [] [
                head [] [
                    meta [ _charset "UTF-8" ]
                    meta [ _name "viewport"; _content "width=device-width, initial-scale=1.0" ]
                    title [] [
                        str $"{applicant.Name}'s CV"
                    ]
                    style [] [
                        str """
                        body {
                            font-family: Arial, sans-serif;
                            line-height: 1.6;
                            margin: 30px 20px;
                        }
                        h1, h2 {
                            color: #000000;
                        }
                        .contact, .skills, .languages, .certifications, .summary, .education, .experience {
                            margin-bottom: 20px;
                        }
                        .skills li, .languages li, .certifications li, {
                            list-style-type: none;
                        }
                        a {
                            color: #0066cc;
                            text-decoration: none;
                        }
                        a:hover {
                            text-decoration: underline;
                        }
                        .responsive-img {
                            max-width: 100%;
                            height: auto;
                            width: 200px;
                            max-height: 300px;
                            object-fit: contain;
                        }
                        
                        .tag {
                          display: inline-block;
                          padding: 5px 10px;
                          margin: 2px 4px;
                          color: #000000;
                          border-radius: 5px 20px 5px;
                          font-size: 10px;
                          font-weight: bold;
                          text-align: center;
                          border: 2px solid #808080;
                        }
                    
                        """
                    ]
                ]
                body [] [ div [] [
                header [] [
                    h1 [] [ str applicant.Name ]
                    h2 [] [ str applicant.Title ]
                    div [ _style "display: flex; justify-content: space-around;" ] [
                        img [ _style "border-radius: 200px;"; _src "https://media.licdn.com/dms/image/v2/D4E03AQHW-BS1wrggPQ/profile-displayphoto-shrink_800_800/profile-displayphoto-shrink_800_800/0/1690660764223?e=1730937600&v=beta&t=m1tolOM-nkgRtBc_UC4MSoKQARc5c17k2JTx0cujSDA"; _alt "Logo"; _class "responsive-img" ]
                        img [ _src "https://topswagcode.com/assets/banner-logo.png"; _alt "Logo"; _class "responsive-img" ]
                    ]
                ]
                section [ _class "contact" ] [
                    h2 [] [ str "Contact" ]
                    p [] [ str $"Phone: {applicant.PhoneNumber}" ]
                    p [] [ a [ _href $"mailto:{applicant.Email}" ] [ str applicant.Email ] ]
                ]
                section [ _class "summary" ] [
                    h2 [] [ str "Summary" ]
                    p [ _id "testing class and id :D"; _class "hahahaha" ] [ str "Hi I am Joshua Jesper Krægpøth Ryder. I love all parts of the software development cycle. Being it business and domain understanding. Discussing and architecting solutions. Pairing and mentoring with team members or getting time to write the code myself. All places I work I have a heavy focus on team development in any way possible. At iPaper I started a book club. At Maersk I was an active contributor to security, general and dotnet learning guilds, giving various talks on different subjects. At Brølstærk I was Pod Lead coordinating learning sessions each Friday." ]
                    p [] [
                            str "In my spare time, I also spend time following tech trends and upskilling myself. Active in different user groups also giving talks from time to time. Spent time creating a YouTube channel. Even got invited to make a live talk on Jetbrain's official YouTube channel ( "
                            a [ _href "https://www.youtube.com/watch?v=jkve_v1Xxak"; _target "_blank" ] [ str "videos" ]
                            str " ). I have a personal goal of getting to do a conference talk at some point in the future."]
                    p [] [ str "Besides being a massive nerd, I also love spending time with my family, traveling, and experiencing new stuff. Using my creative side on painting. Geeking out with my partner playing tabletop games. Some more personal facts: I have spent 13 years with my partner Ina. We have a son (Storm) who is 5 years old. We also have a 12-year-old cat. Last year we moved to a new house in Østbirk where we plan on staying for the next many years." ]
                    p [] [
                        str "Sorry if the CV is a bit ugly. It´s created using a CV generator I wrote in F# and is a work in progress. The code can be found "
                        a [ _href "https://github.com/TopSwagCode/turbo-octo-dollop"; _target "_blank" ] [ str "here" ]
                        str " on github."
                        ]
                    p [] [ str "Strengths:" ]
                    ul [] [
                        li [] [ str "Strong team player." ]
                        li [] [ str "Really good at learning new domains and adopting new technologies." ]
                        li [] [ str "Eager to learn, improve and share." ]
                        li [] [ str "Always welcome new challenges." ]
                    ]
                    p [] [ str "Weaknesses:" ]
                    ul [] [
                        li [] [ str "Taking too much on my plate." ]
                        li [] [ str "Singing" ]
                    ]
                ]
                section [ _class "languages" ] [
                    h2 [] [ str "Languages" ]
                    ul [] [
                        li [] [ str "Danish" ]
                        li [] [ str "English" ]
                        li [] [ str "German" ]
                        
                    ]
                ]
                section [ _class "education" ] [
                    h2 [] [ str "Education" ]
                    ul [] [
                        li [] [ str "AP Degree in Computer Science" ]
                        li [] [ str "Bachelor Degree in Scalable Software Development" ]
                        li [] [ str "25% Masters in Software Construction (Only classes that I had interest in at the time: P2P network, Docker / cloud, and advanced web development)" ]
                    ]
                    p [] [ str "After each degree, I took a \"break\", working for a couple of years and returning to school to level up." ]
                ]
                section [ _class "experience" ] [
                    h2 [] [ str "Experience" ]
                    table [ _class "experience" ] [
                        thead [] [
                            tr [] [
                                th [] [ str "Company" ]
                                th [] [ str "Title" ]
                                th [] [ str "Period" ]
                                th [] [ str "Location" ]
                            ]
                        ]
                        tbody [] (
                            applicant.Experiences |> List.map (fun (experience) ->
                                tr [] [
                                    td [] [ str experience.Company ]
                                    td [] [ str experience.Title ]
                                    td [] [ str experience.Period ]
                                    td [] [ str experience.Location ]
                                ]
                            )
                        )
                    ]
                ]
                section [ _class "certifications" ] [
                    h2 [] [ str "Certifications" ]
                    ul [] [
                        li [] [ str "AZ-900: Microsoft Azure Fundamentals" ]
                    ]
                ]
                section [ _class "Buzz Words" ] [
                    h2 [] [ str "Buzz Words" ]
                    div [] (
                        applicant.BuzzWords |> List.map (fun (buzzWord) ->
                            div [ _class "tag"] [ str buzzWord ])
                    )
                ]
                section [ _class "Skills" ] [
                    h2 [] [ str "Skills" ]
                    div [] (
                        applicant.Skills |> List.map (fun (skill) ->
                            div [ _class "tag"] [ str skill ])
                    )
                ]
            ] ]
        ] |> RenderView.AsString.htmlDocument