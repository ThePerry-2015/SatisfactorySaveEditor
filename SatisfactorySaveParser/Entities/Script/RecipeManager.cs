﻿using System;
using System.IO;

namespace SatisfactorySaveParser.Entities.Script
{
    [SaveEntity("/Script/FactoryGame.FGRecipeManager")]
    public class RecipeManager : SaveEntity
    {
        public override void ParseData(uint length, BinaryReader reader)
        {
            base.ParseData(length, reader);


        }
    }
}