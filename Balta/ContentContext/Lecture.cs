using Balta.ContentContext.Enums;
using Balta.SharedContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balta.ContentContext
{
    public class Lecture : Base
    {
        public int Order { get; set; }
        public string Title { get; set; }
        public int DurantionInMinutes { get; set; }
        public EContentLevel ELevel { get; set; }

    }
}
