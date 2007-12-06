﻿using System;

using org.puremvc.csharp.interfaces;
using org.puremvc.csharp.patterns.command;

namespace org.puremvc.csharp.core.controller
{
    /**
	 * A SimpleCommand subclass used by ControllerTest.
	 *
  	 * @see org.puremvc.csharp.core.controller.ControllerTest ControllerTest
  	 * @see org.puremvc.csharp.core.controller.ControllerTestVO ControllerTestVO
	 */
    public class ControllerTestCommand : SimpleCommand
    {
        /**
		 * Constructor.
		 */
        public ControllerTestCommand()
            : base()
        { }

        /**
		 * Fabricate a result by multiplying the input by 2
		 * 
		 * @param note the note carrying the ControllerTestVO
		 */
		override public void execute( INotification note )
		{
			
			ControllerTestVO vo = note.getBody() as ControllerTestVO;
			
			// Fabricate a result
			vo.result = 2 * vo.input;

		}
    }
}