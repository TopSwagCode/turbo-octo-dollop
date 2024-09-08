# turbo-octo-dollop

A simple CV PDF generator in F#

To be able to run this code it´s important to have headless Chromium installed on your machine.
This can be done manually or by running the following code:

``` F#
let _ = Microsoft.Playwright.Program.Main([| "install" |])
```