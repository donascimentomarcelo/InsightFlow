PROJECT = ./InsightFlow.Api
TEST_PROJECT = ./InsightFlow.Tests

run:
	dotnet run --project $(PROJECT)

build:
	dotnet build

restore:
	dotnet restore

test:
	dotnet test $(TEST_PROJECT)

clean:
	dotnet clean

format:
	dotnet format

watch:
	dotnet watch --project $(PROJECT)

.PHONY: run build restore test clean format watch
