using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public record answer
    {


        public int idAnswer { get; set; }
        public int QuestionId { get; set; }
        public String Text { get; set; }
        public answer() { }
        public answer(int idAnswer, int QuestionId, String Text)
        {
            this.idAnswer = idAnswer;
            this.QuestionId = QuestionId;
            this.Text = Text;
        }
        public override string ToString()
        {
            return $"Answer ID: {idAnswer}, Question ID: {QuestionId}, Text: {Text}";

        }

    }
}
