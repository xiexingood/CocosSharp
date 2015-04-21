﻿using System;

namespace CocosSharp
{
    public class CCGroupCommand : CCRenderCommand
    {
        internal bool Begin { get; set; }

        public CCGroupCommand(float globalZOrder, bool begin = true )
            : base (globalZOrder)
        {
            CommandType = CCRenderCommandType.Group;
            Begin = begin;
        }

        internal override void Execute(CCDrawManager drawManager)
        {
            //throw new NotImplementedException();
        }
    }
}
