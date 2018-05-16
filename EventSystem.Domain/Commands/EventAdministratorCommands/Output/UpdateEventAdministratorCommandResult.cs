﻿using System;
using EventSystem.Shared.Commands;

namespace EventSystem.Domain.Commands.EventAdministratorCommands.Output
{
	public class UpdateEventAdministratorCommandResult : ICommandResult
	{

		public UpdateEventAdministratorCommandResult()
		{
		}
		
		public UpdateEventAdministratorCommandResult(Guid id, string name, string email)
		{
			Id = id;
			Name = name;
			Email = email;
		}

		public Guid Id { get; set; }
		public Guid AdminidstratorId { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
	}
}