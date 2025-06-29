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

migrate:
	dotnet ef migrations add $(MIGRATION_NAME) --project $(INFRA_PROJECT) --startup-project $(PROJECT)

update:
	dotnet ef database update --project $(INFRA_PROJECT) --startup-project $(PROJECT)

reset:
	dotnet ef database drop --project $(INFRA_PROJECT) --startup-project $(PROJECT) --force --no-build
	make migrate
	make update

up:
	docker-compose up -d

down:
	docker-compose down

.PHONY: run build restore test clean format watch
