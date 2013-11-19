using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalRedis
{
    public class Render
    {
        private StringBuilder result = null;

        public Render()
        {
            this.result = new StringBuilder();
        }

        public void AppendWords(byte[][] listOfWords)
        {
            this.result.AppendLine();
            this.result.AppendLine("This are all words:");

            foreach (var word in listOfWords)
            {
                this.result.AppendLine(RedisFormatParser.StringFromByteArray(word));
            }
        }

        public void AppendTranslation(byte[] translation)
        {
            this.result.AppendLine("Translation:" + RedisFormatParser.StringFromByteArray(translation));
        }

        public void Execute()
        {
            Console.WriteLine(this.result);
        }
    }
}
