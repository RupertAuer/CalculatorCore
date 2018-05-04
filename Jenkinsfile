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
      
      post {
        success {
          archiveArtifacts 'target/*.hpi,target/*.jpi'
        }
      } 
    }
    stage('Test') {
      steps {
        sh 'dotnet test '
      }
       post {
        always {
          junit '**surefire-reports/**/*.xml'
        }
      } 
    }
  }
}
