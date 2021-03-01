
pipeline{
	agent any
	environment{
		scannerHome = tool name : 'sonar_scanner', type : 'hudson.plugins.sonar.MsBuildSQRunnerInstallation'
	}
	options{
		disableConcurrentBuilds()
	}
	stages{
		stage('checkout'){
			steps{
				echo 'checkout from scm'
				checkout scm
			}
		}

		stage('nuget restore'){
			steps{
				echo 'restore'
				bat 'dotnet restore'
			}
		}

		stage('Start Sonar Analysis'){
			steps{
				echo 'start sonar'
				withSonarQubeEnv('Test_Sonar'){
					bat 'dotnet "C:/Program Files (x86)/Jenkins/tools/hudson.plugins.sonar.MsBuildSQRunnerInstallation/sonar_scanner/SonarScanner.MSBuild.dll" begin /k:Pipeline.First /n:Pipeline.First /v:1.0'
				}
			}
		}

		stage('Build'){
			steps{
				echo 'dotnet build'
				bat 'dotnet build'
			}
		}

		stage('End Sonar Analysis'){
			steps{
				echo 'end sonar'
				withSonarQubeEnv('Test_Sonar'){
					bat 'dotnet "C:/Program Files (x86)/Jenkins/tools/hudson.plugins.sonar.MsBuildSQRunnerInstallation/sonar_scanner/SonarScanner.MSBuild.dll" end'
				}
			}
		}

		stage('Release Artifacts'){
			steps{
				echo 'artifacts'
				bat 'dotnet publish -c Release -o ./WebApplication1/meenakshi'
			}
		}
	}
}
