name = "JV"
CharacterBehaviour = nil;

id = 2

 function Update() 
        
       SetNearPlayerDestination()

        if IsNear() == false then
         Attack()
         end

   if Souls() >= 2 then
        ReturnToBase()
    end  

 


end

 function Souls() 

    return CharacterBehaviour.playerScript.Souls;

 end


function IsNear() 
    return (CharacterBehaviour.playerAgent.remainingDistance <= CharacterBehaviour.playerAgent.stoppingDistance+2)

end


