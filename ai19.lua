name = "SuSu"
CharacterBehaviour = nil;

id = 2

function Update()


SetNearPlayerDestination()



if(Souls() >= 5)then
	ReturnToBase()
	
end

if(IsNear())then


Attack()


	
end


end



function IsNear() 
    return (CharacterBehaviour.playerAgent.remainingDistance >= CharacterBehaviour.playerAgent.stoppingDistance+2)

end

function Souls() 

   return CharacterBehaviour.playerScript.Souls;

end

