using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Structural.Composite
{
    public static class Starter
    {
        public static void Run()
        {
            var scrapbook = new ScrapbookObject();
            
            // Add individual objects to a scrapbook
            scrapbook.Children.Add(new ScrapbookText());
            scrapbook.Children.Add(new ScrapbookScribble());
            scrapbook.Children.Add(new ScrapbookSticker());

            // Create a group of objects and add the group to a scapbook
            var pictureGroup = new ScrapbookObject();
            pictureGroup.Children.Add(new ScrapbookPicture());
            pictureGroup.Children.Add(new ScrapbookPicture());

            var group = new ScrapbookObject();
            group.Children.Add(new ScrapbookText());
            group.Children.Add(pictureGroup);

            scrapbook.Children.Add(group);

            Console.WriteLine(scrapbook.ToString());
        }
    }
}
