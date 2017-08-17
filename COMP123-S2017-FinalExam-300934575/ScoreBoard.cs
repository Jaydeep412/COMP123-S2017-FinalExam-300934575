using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2017_FinalExam_300934575
{

    /*
     * Name: Jaydeep Lakhwani
     * Date: 17th August, 2017
     * StudentID: 300934575
     * Description: This is the ScorBoard class for pickHighestCard class.
     * Version 0.1 : ScoreBoard class created.
     */
    class ScoreBoard
    {
        //PRIVATE INSTANCE VARIABLES
        private TextBox _finalScoreTextBox;

        private int _score;

        private TextBox _scoreTextBox;

        private int _time;

        private TextBox _timeTextBox;

        //PUBLIC PROPERTIES

        public TextBox FinalScoreTextBox
        {
            get
            {
                return this._finalScoreTextBox;
            }
            set
            {
                this._finalScoreTextBox = value;
            }
        }

        public int Score
        {
            get
            {
                return this._score;
            }
            set
            {
                this._score = value;
            }
        }
        public TextBox ScoreTextBox
        {
            get
            {
                return this._scoreTextBox;
            }
            set
            {
                this._scoreTextBox = value;
            }
        }

        public int Time
        {
            get
            {
                return this._time;
            }
            set
            {
                this._time = value;
            }
        }

        public TextBox TimerTextBox
        {
            get
            {
                return this._timeTextBox;
            }
            set
            {
                this._timeTextBox = value;
            }
        }

        
    }
}
