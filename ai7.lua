-- Defina um nome com até 6 caracteres (sem acentos e cedilha)
name = "JNasci"

-- clase c# que contém o Script do player (playerScript) e um NavMesAgent (playerAgent)
CharacterBehaviour = nil;


 function Update() 
     -- verificando o número de almas/pontos acompanhando o jogador
    if Souls() <= 2 then
      SetNearPlayerDestination()
        -- realiza uma ação
    end  

    -- verificando se o personagem está próximo do alvo previamente definido
    if IsNear() == true then
       Attack()
    end
    if Souls() == 3 then
       ReturnToBase()
    end


    -- DEFINE UM PERSONAGEM COMO ALVO
    -- INFELIZMENTE A LISTA NÃ FICOU ORDENADA E POSSIVELMENTE ESTA ALEATORIA
    -- SetNearPlayerDestination()



    -- ATACA NÉ
    -- O ATAQUE TEM UM COOLDOWN DE 1 SEGUNDO ANTES DE RETORNAR AO NORMAL
    --Attack()



    -- RETORNA PARA A BASE
    --ReturnToBase()



end




-- VERIFICA SE ESTA PRÓXIMO DO ALVO PREVIAMENTE DEFINIDO. O NÚMERO 2 AJUSTA A DISTANCIA. 
function IsNear() 
    return (CharacterBehaviour.playerAgent.remainingDistance >= CharacterBehaviour.playerAgent.stoppingDistance+2)

end

-- número de almas/pontos acompanhando o jogador
 function Souls() 
    return CharacterBehaviour.playerScript.Souls;
 end



