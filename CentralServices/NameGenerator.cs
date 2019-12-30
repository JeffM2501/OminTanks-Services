﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CentralServices
{
    public static class NameGenerator
    {

        private static string[] FirstNames = new string[]{  "Magic",
                                                            "Lemon",
                                                            "Sweetie",
                                                            "Frosty",
                                                            "Jewel",
                                                            "Brilliant",
                                                            "Stormy",
                                                            "Twinkle",
                                                            "Dewdrop",
                                                            "Sky",
                                                            "Pepper",
                                                            "Dusty",
                                                            "Fire",
                                                            "Sparkle",
                                                            "Midnight",
                                                            "Crystal",
                                                            "Cool",
                                                            "Minty",
                                                            "Cloud",
                                                            "Citrus",
                                                            "Peach",
                                                            "Bubble",
                                                            "Berry",
                                                            "Light",
                                                            "Beauty",
                                                            "Rose",
                                                            "Dawn",
                                                            "Cocoa",
                                                            "Summer",
                                                            "Star",
                                                            "Speedy",
                                                            "Whirly",
                                                            "Lucky",
                                                            "Gold",
                                                            "Fancy",
                                                            "Silver",
                                                            "Lucky",
                                                            "Dancing",
                                                            "Lightning",
                                                            "Sunshine",
                                                            "Scarlet",
                                                            "Ocean",
                                                            "Peppermint",
                                                            "Midnight",
                                                            "Stone",
                                                            "Frozen",
                                                            "Quirk",
                                                            "Mythic",
                                                            "Smooth",
                                                            "Morning",
                                                            "Magic",
                                                            "Azure",
                                                            "Sapphire",
                                                            "Delilah",
                                                            "Starry",
                                                            "Velvet",
                                                            "Ruby",
                                                            "Dew",
                                                            "Fluffy",
                                                            "Shadow",
                                                            "Swift",
                                                            "Rapid",
                                                            "Crimson",
                                                            "Blaze",
                                                            "Solar",
                                                            "Nimble",
                                                            "Shining",
                                                            "Berry",
                                                            "Emerald",
                                                            "Violet",
                                                            "Ivory",
                                                            "Ice",
                                                            "Rose",
                                                            "Marble",
                                                            "Straight",
                                                            "Rocky",
                                                            "Moonshadow",
                                                            "Arctic",
                                                            "Prince"
                                                            };

        private static string[] LastNamed = new string[] { "Red",
                                                            "Mint",
                                                            "Flip",
                                                            "Skipper",
                                                            "Dahlia",
                                                            "Tangy",
                                                            "Pink",
                                                            "Berry",
                                                            "Poppy",
                                                            "Bright",
                                                            "Glow",
                                                            "Sugar",
                                                            "Dasher",
                                                            "Muffin",
                                                            "Dash",
                                                            "Comet",
                                                            "Onyx",
                                                            "Glory",
                                                            "Treat",
                                                            "Apple",
                                                            "Lilac",
                                                            "Dreams",
                                                            "Emerald",
                                                            "Jubilee",
                                                            "Joy",
                                                            "Heart",
                                                            "Eyes",
                                                            "Sunset",
                                                            "Pie",
                                                            "Blueberry",
                                                            "Flitter",
                                                            "Magenta",
                                                            "Hooves",
                                                            "Manes",
                                                            "Prize",
                                                            "Star",
                                                            "Chaser",
                                                            "Wing",
                                                            "Sapphire",
                                                            "Sunshine",
                                                            "Steps",
                                                            "Hoof",
                                                            "Smirk",
                                                            "Tooth",
                                                            "Might",
                                                            "Heart",
                                                            "Moon",
                                                            "Swing",
                                                            "Dusk",
                                                            "Diamond",
                                                            "Cupcake",
                                                            "Wings",
                                                            "Aurora",
                                                            "Snow",
                                                            "Rain",
                                                            "Eyes",
                                                            "Twister",
                                                            "Bolt",
                                                            "Shadow",
                                                            "Mask",
                                                            "Blaze",
                                                            "Hero",
                                                            "Charge",
                                                            "Rock",
                                                            "Aura",
                                                            "Sparkle",
                                                            "Lucy",
                                                            "Flower",
                                                            "Jewel",
                                                            "Night",
                                                            "Mark",
                                                            "Arrow",
                                                            "Force",
                                                            "Road",
                                                            "Venture",
                                                            "Armor",
                                                            "Strikes",
                                                            "Hunter"
                                                            };

        private static Random RNG = new Random();

        private static string RandomElement(string[] contents)
        {
            return contents[RNG.Next(contents.Length)];
        }

        public static string Generate()
        {
            return RandomElement(FirstNames) + RandomElement(LastNamed) + RNG.Next(12, 99).ToString();
        }
    }
}