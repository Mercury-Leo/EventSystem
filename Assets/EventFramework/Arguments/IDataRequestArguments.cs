using System;
using EventFramework.Arguments.Abstractions;
using UnityEngine;

namespace EventFramework.Arguments {
	public interface IDataRequestArguments {
		Action CallBack { get; }
		
		GameObject GameObject { get; }
		
	    IEventArguments EventArguments { get; }
	}
}