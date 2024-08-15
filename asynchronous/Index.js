console.log('Before')
getuser(1,(user)=>{
    console.log('User',user);
    console.log(user.githubusername);
});
console.log('After');


function getuser(id,callback){
    setTimeout(()=>{
        console.log('Reading a user from a database...');
        callback({id:id,githubusername:'Musthaffa'});
    },2000);
}