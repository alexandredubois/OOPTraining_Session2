namespace OOPTrainingTests
{
    public static class ReflectionTools
    {
        /// <summary>
        /// Cette méthode me permet de vérifier qu'une classe que je connais, possède certaines propriétés qui n'existent pas aux moment où j'écris
        /// mes tests unitaires. Cela permettra à mes apprenants de savoir s'ils sont sur la bonne piste ;)
        /// </summary>
        /// <param name="obj">L'objet à tester</param>
        /// <param name="propertyName">La propriété dont on cherche à vérifier l'existence</param>
        /// <returns>True si la propriété existe, false sinon</returns>
        public static bool HasProperty(this object obj, string propertyName)
        {
            return obj.GetType().GetProperty(propertyName) != null;
        }
    }
}
