// <copyright file="SolutionTest.cs">Copyright ©  2016</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using binarygap;

namespace binarygap.Tests
{
    /// <summary>This class contains parameterized unit tests for Solution</summary>
    [PexClass(typeof(Solution))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class SolutionTest
    {
        /// <summary>Test stub for solution(Int32)</summary>
        [PexMethod]
        public int solutionTest([PexAssumeUnderTest]Solution target, int N)
        {
            int result = target.solution(N);
            return result;
            // TODO: add assertions to method SolutionTest.solutionTest(Solution, Int32)
        }
    }
}
