using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MadsenCreekRazor.Data;
using System;
using System.Linq;

namespace MadsenCreekRazor.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MadsenCreekRazorContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MadsenCreekRazorContext>>()))
            {
                // Look for any Beers.
                if (context.Beer.Any())
                {
                    return;   // DB has been seeded
                }

                context.Beer.AddRange(
                    new Beer
                    {
			            name ="Flotilla IPA",
			            style="Summertime IPA",
			            description= "Light IPA brewed for drinkability at 90 degrees while floating on a lake.",
			            untappedLink= "",
			            recipeLink= "https://www.brewersfriend.com/homebrew/recipe/view/247925/flotilla-ipa"
                    },

                    new Beer
                    {
                        name="Homegrown IPA",
                        style="American IPA",
                        description= "Beer brewed with homegrown Columbus, Centennial, and Cascade.",
                        untappedLink= "https://untappd.com/qr/beer/2319943",
                        recipeLink= "https://www.brewersfriend.com/homebrew/recipe/view/287127/homegrown-ipa"
                    },

                    new Beer
                    {
                        name="Just a Tribute",
                        style="Imperial IPA",
                        description= "Tribute to another undisclosed imperial IPA. This is not The Greatest Beer in the World, no. This is Just a Tribute.",
                        untappedLink= "",
                        recipeLink= "https://www.brewersfriend.com/homebrew/recipe/view/185910/just-a-tribute"
                    },

                    new Beer
                    {
                        name="Old Big Red",
                        style="Imperial Red",
                        description= "Strong Imperial Red ale with scottish yeast. Named after the little known \"Old Big Red\" in Moscow's Red Square.",
                        untappedLink= "https://untappd.com/qr/beer/1919775",
                        recipeLink= "https://www.brewersfriend.com/homebrew/recipe/view/218581/old-big-red"
                    },
                    new Beer
                    {
                        name="Manneken Pis",
                        style="Belgian Golden Ale",
                        description= "As advertised.",
                        untappedLink= "",
                        recipeLink= "https://www.brewersfriend.com/homebrew/recipe/view/148941/manneken-pis"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}