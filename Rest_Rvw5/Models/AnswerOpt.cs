using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Rest_Rvw5.Models
{
  public class AnswerOpt
  {
    [Key]
    public int Id { get; set; }
    [ForeignKey("Question")]
    public int QuestionId { get; set; }
    public int Seq { get; set; }
    public int Value { get; set; }
    public string OptText { get; set; }
    public virtual Question Question { get; set; }

    public AnswerOpt()
    {
      Id = 0;
      QuestionId =  0;
      Seq =         0;
      Value =       0;
      OptText =     "";
    }

    public AnswerOpt(int answerOptId, int questionId, int seq, int value, string optText)
    {
      Id = answerOptId;
      QuestionId =  questionId;
      Seq =         seq;
      Value =       value;
      OptText =     optText;
    }
  }
}