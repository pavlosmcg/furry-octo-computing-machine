﻿using System;

namespace Assembler.Instructions
{
    public struct LabelInstruction : IInstruction, IEquatable<LabelInstruction>
    {
        private readonly string _label;

        public LabelInstruction(string label)
        {
            _label = label;
        }

        public string Label
        {
            get { return _label; }
        }

        public void Accept<T>(IInstructionVisitor<T> instructionVisitor)
        {
            instructionVisitor.VisitInstruction(this);
        }

        public bool Equals(LabelInstruction other)
        {
            return string.Equals(other.Label, Label);
        }
    }
}