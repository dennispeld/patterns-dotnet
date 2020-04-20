using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Structural.Composite
{
    public enum Type
    {
        Text,
        Scribble,
        Picture,
        Sticker,
        Group
    }

    public class ScrapbookObject
    {
        public virtual Type Type { get; set; } = Type.Group;

        private readonly Lazy<List<ScrapbookObject>> children = new Lazy<List<ScrapbookObject>>();
        public List<ScrapbookObject> Children => children.Value;

        public void PrintScrapbookObjects(StringBuilder sb, int depth)
        {
            sb.Append(new string('*', depth)).AppendLine(Type.ToString());

            foreach (var child in Children) {
                child.PrintScrapbookObjects(sb, depth + 1);
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            PrintScrapbookObjects(sb, 0);

            return sb.ToString();
        }
    }

    public class ScrapbookText: ScrapbookObject
    {
        public override Type Type => Type.Text;
    }

    public class ScrapbookScribble: ScrapbookObject
    {
        public override Type Type => Type.Scribble;
    }

    public class ScrapbookPicture: ScrapbookObject
    {
        public override Type Type => Type.Picture;
    }

    public class ScrapbookSticker: ScrapbookObject
    {
        public override Type Type => Type.Sticker;
    }
}
