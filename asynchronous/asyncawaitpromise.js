//Async Await
function getUser(id){
    return new Promise((resolve,reject)=>{
        setTimeout(()=>{
            console.log('Reading a user from a database...');
            resolve({id: id,getHubUsername:'kfayazuddin'});
        },2000);
    });
}

function getRepositories(username)
{
    return new Promise((resolve,reject)=>{
        setTimeout(()=>{
            console.log('Calling GitHub API....');
            resolve(['repo1','repo2','repo3']);
        },2000);
    });
}


function getCommits(repo) {
return new Promise((resolve,reject)=>{
    setTimeout(() => {
      console.log('Calling GitHub API...');
      resolve(['commit']);
    }, 2000);
  });
}

async function displayCommits(){
    try{
        const user = await getUser(1);
        const repos =  await getRepositories(user.getHubUsername);
        const commits =  await getCommits(repos[0]);
        console.log(commits);
    }
    catch(err){
        console.log('Error',err.message);
    }
}
displayCommits();

