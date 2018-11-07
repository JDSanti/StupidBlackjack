﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupidBlackjackSln.Code{
    public abstract class Bot{
        public int Score{
            get;
            protected set;}
        public List<Card> Hand{
            get;
            protected set;}
        public Bot(){
            Score = 0;}
        public void giveHand(List<Card> initHand){
            Hand = initHand;
            calcScore();}
        public void giveCard(Card card){
            Hand.Add(card);
            calcScore();}
        protected abstract void calcScore();
        protected abstract void takeTurn();
    }
}
