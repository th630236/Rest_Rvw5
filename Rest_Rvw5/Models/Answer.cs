using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Rest_Rvw5.Models
{
  public class Answer
  {
    [Key]  
    [Column(Order = 10)]
    [ForeignKey("Review")]
    public int ReviewId { get; set; }
    [Key]
    [Column(Order = 20)]
    [ForeignKey("Question")]
    public int QuestionId { get; set; }
    public int? Response { get; set; }
    public string AnswerText { get; set; }
    public virtual Review Review { get; set; }
    public virtual Question Question { get; set; }

    public Answer()
    {
      ReviewId =   0;
      QuestionId = 0;
      Response =   null;
      AnswerText = "";
    }

    public Answer(int answerId, int reviewId, int questionId, int? response, string answerText)
    {
      ReviewId =   reviewId;
      QuestionId = questionId;
      Response =   response;
      AnswerText = answerText;
    }
  }
}