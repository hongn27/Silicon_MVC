using Silicon.Models.Sections;

namespace Silicon.Models.Views;

public class HomeIndexViewModel
{
    public string Title { get; set; } = "Task Management Assistant"!;
    public ShowcaseViewModel Showcase { get; set; } = new ShowcaseViewModel
    {
        Id = "overview",
        ShowcaseImage = new() { ImageUrl = "images/showcase-taskmaster.svg", AltText = "Task Management Assistant" },
        Title = "Task Management Assistant You Gonna Love",
        Text = "We offer you a new generation of task management system. Plan, manage & track all your tasks in one flexible tool.",
        Link = new() { ControllerName = "Downloads", ActionName = "Index", Text = "Get started for free" },
        BrandsText = "Largest companies use our tool to work efficiently",
        Brands =
                [
                    new() { ImageUrl = "images/Brands/Brand_1.svg", AltText = "Brand name 1"},
                    new() { ImageUrl = "images/Brands/Brand_2.svg", AltText = "Brand name 2"},
                    new() { ImageUrl = "images/Brands/Brand_3.svg", AltText = "Brand name 3"},
                    new() { ImageUrl = "images/Brands/Brand_4.svg", AltText = "Brand name 4"},
                ]
    };
}    


