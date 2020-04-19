using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Structural.Adapter
{
    public class Book: IBook
    {
        public string Title { get; }
        public string Author { get; }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public string Read(int page)
        {
            // for the example, we simply hardcore a random text
            return $"Page {page}. Those an equal point no years do. Depend warmth fat but her but played. Shy and subjects wondered trifling " +
                "pleasant. Prudent cordial comfort do no on colonel as assured chicken. Smart mrs day which begin. Snug do sold mr it if such. " +
                "Terminated uncommonly at at estimating. Man behaviour met moonlight extremity acuteness direction. As am hastily invited " +
                "settled at limited civilly fortune me. Really spring in extent an by. Judge but built happy party world. Of so am he " +
                "remember although required. Bachelor unpacked be advanced at. Confined in declared marianne is vicinity. Supplied directly " +
                "pleasant we ignorant ecstatic of jointure so if. These spoke house of we. Ask put yet excuse person see change. Do " +
                "inhabiting no stimulated unpleasing of admiration he. Enquire explain another he in brandon enjoyed be service. Given mrs " +
                "she first china. Table party no or trees an while it since. On oh celebrated at be announcing dissimilar insipidity. " +
                "Ham marked engage oppose cousin ask add yet. Inquietude simplicity terminated she compliment remarkably few her nay. " +
                "The weeks are ham asked jokes. Neglected perceived shy nay concluded. Not mile draw plan snug next all. Houses latter an " +
                "valley be indeed wished merely in my. Money doubt oh drawn every or an china. Visited out friends for expense message set " +
                "eat. Placing assured be if removed it besides on. Far shed each high read are men over day. Afraid we praise lively he " +
                "suffer family estate is. Ample order up in of in ready. Timed blind had now those ought set often which. Or snug dull he " +
                "show more true wish. No at many deny away miss evil. On in so indeed spirit an mother. Amounted old strictly but marianne " +
                "admitted. People former is remove remain as.";
        }
    }
}
