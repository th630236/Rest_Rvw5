using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace Rest_Rvw5.Models
{
  public class Question
  {
    [Key]
    public int QuestionId { get; set; }
    public bool Active { get; set; }
    public int QuestionNum { get; set; }
    public int QuestionType { get; set; }
    public string QuestionText { get; set; }
 
    public Question()
    {
      QuestionId =   0;
      Active =       false;
      QuestionNum =  0;
      QuestionType = 0;
      QuestionText = "";
     }

    public Question(int questionId, bool active, int questionNum, int questionType, string questionText)
    {
      QuestionId =   questionId;
      Active =       active;
      QuestionNum =  questionNum;
      QuestionType = questionType;
      QuestionText = questionText;
    }
  }
}