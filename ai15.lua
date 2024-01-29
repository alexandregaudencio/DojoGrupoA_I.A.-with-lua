name = "Paola"
CharacterBehaviour = nil;

id = 3

function Update()

SetNearPlayerDestination()



if(Souls() >= 1)then
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

    