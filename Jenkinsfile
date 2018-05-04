pipeline {
  agent {
    docker {
      image 'microsoft/dotnet'
    }

  }
  stages {
    stage('Git') {
      steps {
        git(url: 'https://github.com/RupertAuer/CalculatorCore', branch: 'master', poll: true)
      }
    }
    stage('build') {
      steps {
        sh 'dotnet build'
      }
    }
    stage('Test') {
      steps {
        sh 'dotnet test -r results'
      }
    }
  }
}