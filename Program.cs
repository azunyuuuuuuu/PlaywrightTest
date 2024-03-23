using Microsoft.Playwright;

Console.WriteLine("Hello, World!");

using var playwright = await Playwright.CreateAsync();
await using var browser = await playwright.Chromium.LaunchAsync();

var page = await browser.NewPageAsync();
await page.GotoAsync("https://azunyu.moe/");

await page.ScreenshotAsync(new()
{
    Path = "screenshot.png"
});

await page.PdfAsync(new()
{
    Path = "printed.pdf",
    Format = "A4"
});