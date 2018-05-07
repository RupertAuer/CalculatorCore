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
    stage('Build') {
      steps {
        sh 'dotnet build'
      }
    }
    stage('Test') {
      parallel {
        stage('Test') {
          steps {
            sh 'dotnet test'
          }
        }
        stage('List Tests') {
          steps {
            sh 'dotnet test -t'
          }
        }
      }
    }
    stage('Run') {
      steps {
        sh 'dotnet run -p RunCalculator'
      }
    }
    stage('publish') {
      steps {
        sh 'dotnet publish '
      }
    }
    stage('') {
      steps {
        sh 'docker build'
      }
    }
  }
}