﻿using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper.Clickables
{
    public abstract class IButton
    {
        public bool canBeClicked;
        public Rectangle BoundingBox;


        public IButton(Rectangle bb, bool clickable = true)
        {
            BoundingBox = bb;
            canBeClicked = clickable;
        }

        public bool CheckCollision(Vector2 point)
        {
            if (BoundingBox.X < point.X && BoundingBox.Y < point.Y && BoundingBox.X + BoundingBox.Width > point.X && BoundingBox.Y + BoundingBox.Height > point.Y)
                return true;
            return false;
        }

        public virtual void Update()
        {
            //if (CheckCollision())
            OnClick();
        }

        public bool OnClick()
        {
            if (!canBeClicked)
                return false;
            ClickEvent();
            return true;
        }

        public virtual void ClickEvent()
        {

        }

        public virtual void Draw(SpriteBatch spritebatch)
        {

        }
    }
}