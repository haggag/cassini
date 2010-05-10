﻿/* **********************************************************************************
 *
 * Copyright (c) Tanzim Saqib. All rights reserved.
 *
 * This source code is subject to terms and conditions of the Microsoft Public
 * License (Ms-PL). A copy of the license can be found in the license.htm file
 * included in this distribution.
 *
 * You must not remove this notice, or any other, from this software.
 *
 * For continued development:   http://www.TanzimSaqib.com
 * Source:                      http://cassini.googlecode.com/
 * License information:         http://www.opensource.org/licenses/ms-pl.html
 *
 * **********************************************************************************/

namespace Cassini
{
    using System;
    using System.Collections.Generic;

    public interface ICommand
    {
        //dynamic ExecuteParallel(Queue<CassiniTask> tasks);
        void Execute(Queue<CassiniTask> tasks);
        void Execute();
        void Cancel();
        void Cancel(Exception e);
        CommandStatus GetStatus();
        int GetProgressStep();
        int GetTotalProgressSteps();
        string GetProgressText();
        void SetException(Exception e);
        void SetResult(dynamic result);
        CassiniTaskResult GetResult();
    }
}