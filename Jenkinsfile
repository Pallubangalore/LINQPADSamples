pipeline {
    agent any
    stages {
        stage('build') {
            steps {
			
			tools {
         maven '3.5.0' 
    }
                sh 'mvn --version'
            }
        }
    }
}