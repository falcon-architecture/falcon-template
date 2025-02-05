add:
	dotnet nuget add source ./bin/Release --name LocalSource

pack:
	dotnet pack	

install: pack
	dotnet new install ./bin/Release/*.nupkg --force

reinstall: uninstall pack
	dotnet new install ./bin/Release/*.nupkg --force	

uninstall:	
	dotnet new uninstall Falcon.Templates

test: pack uninstall install

clean: uninstall
	dotnet clean
	rimraf obj
	rimraf bin
