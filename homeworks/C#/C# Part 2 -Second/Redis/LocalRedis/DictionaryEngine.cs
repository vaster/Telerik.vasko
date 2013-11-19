using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ServiceStack.Redis;

namespace LocalRedis
{
    public class DictionaryEngine
    {
        private RedisClient redisClient = null;

        private Render render = null;

        public DictionaryEngine()
        {
            this.redisClient = new RedisClient("127.0.0.1:6379");
        }

        public void AddWord(string word, string translation)
        {
            using (this.redisClient)
            {
                this.redisClient.SAdd("words", RedisFormatParser.ToAsciiCharArray(word));
                this.redisClient.HSet("word:" + word, RedisFormatParser.ToAsciiCharArray(word), RedisFormatParser.ToAsciiCharArray(translation));
            }
        }

        public Render ListWords()
        {
            this.render = new Render();

            byte[][] listOfWords = this.redisClient.SMembers("words");

            render.AppendWords(listOfWords);

            return this.render;
        }

        public Render FindWord(string word)
        {
            this.render = new Render();

            byte[] translation = this.redisClient.HGet("word:" + word,RedisFormatParser.ToAsciiCharArray(word));

            this.render.AppendTranslation(translation);

            return this.render;
        }
    }
}
