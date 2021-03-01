
pipeline{
	agent any
	environment{

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
	}
}