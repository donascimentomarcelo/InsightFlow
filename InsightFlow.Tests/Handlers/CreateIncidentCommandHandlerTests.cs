using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using FluentAssertions;
using FluentValidation;
using FluentValidation.Results;
using InsightFlow.Application.commands;
using InsightFlow.Application.Events;
using InsightFlow.Application.Handlers;
using InsightFlow.Application.Repositories;
using InsightFlow.Application.Services;
using InsightFlow.Domain;
using MediatR;
using Moq;

namespace InsightFlow.Tests.Handlers
{
    public class CreateIncidentCommandHandlerTests
    {
        [Fact]
        public async Task Handle_ShouldCreateIncidentAndCallRepository()
        {
            var command = new CreateIncidentCommand(
                Title: "Test Incident",
                Description: "This is a test incident description."
            );

            var repositoryMock = new Mock<IIncidentRepository>();
            var validatorMock = new Mock<IValidator<CreateIncidentCommand>>();
            var mapperMock = new Mock<IMapper>();
            var mediatorMock = new Mock<IMediator>();

            validatorMock
                .Setup(x => x.ValidateAsync(command, It.IsAny<CancellationToken>()))
                .ReturnsAsync(new ValidationResult());
            mapperMock
                .Setup(x => x.Map<Incident>(It.IsAny<CreateIncidentCommand>()))
                .Returns(new Incident(command.Title, command.Description));
            repositoryMock
                .Setup(x => x.AddAsync(It.IsAny<Incident>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new Incident(Guid.NewGuid(), command.Title, command.Description));

            var handler = new CreateIncidentCommandHandler(
                repository: repositoryMock.Object,
                validator: validatorMock.Object,
                mapper: mapperMock.Object,
                mediator: mediatorMock.Object);

            var response = await handler.Handle(command, CancellationToken.None);

            response.Should().NotBeNull();
            repositoryMock.Verify(x => x.AddAsync(It.IsAny<Incident>(), It.IsAny<CancellationToken>()), Times.Once);
            mediatorMock.Verify(x => x.Publish(It.IsAny<IncidentEvent>(), It.IsAny<CancellationToken>()), Times.Once);
        }
    }
}