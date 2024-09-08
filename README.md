# turbo-octo-dollop

A simple CV PDF generator in F#

To be able to run this code it´s important to have headless Chromium installed on your machine.
This can be done manually or by running the following code:

``` F#
let _ = Microsoft.Playwright.Program.Main([| "install" |])
```

There is also Integration tests that install the tool that can be run.

Feel free to come with feedback. Styling is still work in progress.