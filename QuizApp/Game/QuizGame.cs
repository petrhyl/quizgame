using QuizApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Game
{
    public class QuizGame
    {
        public QuizGame(List<QuizModel> quizModelList)
        {
            _quizModleList=quizModelList;
            currentClaimIndex=0;
            numberOfClaims=quizModelList.Count;
            points = 0;
        }
        private List<QuizModel>? _quizModleList;
        private int currentClaimIndex;
        private int numberOfClaims;
        private int points;

        public int Points { get => points; private set=>points=value; }
        public int CurrentClaimIndex { get => currentClaimIndex; private set => currentClaimIndex = value; }

        public string GetCurrentClaim()
        {
            return _quizModleList[currentClaimIndex].Question;
        }

        public int GetNumberOfClaimsToAnswer()
        {
            return numberOfClaims- currentClaimIndex;
        }

        public bool IsRightAnswer(bool trueFalse)
        {
            if (trueFalse) {
                if (_quizModleList[currentClaimIndex].CorrectAnswer.ToLower().Equals("true")) {
                    points++;
                    return true;
                }
                return false;
            }
            if (_quizModleList[currentClaimIndex].CorrectAnswer.ToLower().Equals("false")) {
                points++;
                return true;
            }
            return false;
        }

        public bool CallNextClaim()
        {
            if ((numberOfClaims-1)== currentClaimIndex) {
                return false;
            }
            currentClaimIndex++;
            return true;
        }
    }
}
