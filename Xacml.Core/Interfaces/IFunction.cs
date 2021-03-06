/* ***** BEGIN LICENSE BLOCK *****
 * Version: MPL 1.1/GPL 2.0/LGPL 2.1
 *
 * The contents of this file are subject to the Mozilla Public License Version
 * 1.1 (the "License"); you may not use this file except in compliance with
 * the License. You may obtain a copy of the License at
 * http://www.mozilla.org/MPL/
 *
 * Software distributed under the License is distributed on an "AS IS" basis,
 * WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
 * for the specific language governing rights and limitations under the
 * License.
 *
 * The Original Code is www.com code.
 *
 * The Initial Developer of the Original Code is
 * Lagash Systems SA.
 * Portions created by the Initial Developer are Copyright (C) 2004
 * the Initial Developer. All Rights Reserved.
 *
 * Contributor(s):
 *   Diego Gonzalez <diegog@com>
 *
 * Alternatively, the contents of this file may be used under the terms of
 * either of the GNU General Public License Version 2 or later (the "GPL"),
 * or the GNU Lesser General Public License Version 2.1 or later (the "LGPL"),
 * in which case the provisions of the GPL or the LGPL are applicable instead
 * of those above. If you wish to allow use of your version of this file only
 * under the terms of either the GPL or the LGPL, and not to allow others to
 * use your version of this file under the terms of the MPL, indicate your
 * decision by deleting the provisions above and replace them with the notice
 * and other provisions required by the GPL or the LGPL. If you do not delete
 * the provisions above, a recipient may use your version of this file under
 * the terms of any one of the MPL, the GPL or the LGPL.
 *
 * ***** END LICENSE BLOCK ***** */

using ctx = Xacml.Core.Context;
using pol = Xacml.Core.Policy;
using rtm = Xacml.Core.Runtime;
using typ = Xacml.Core.Runtime.DataTypes;
using inf = Xacml.Core.Interfaces;

namespace Xacml.Core.Interfaces
{
	/// <summary>
	/// Defines a function that can be executed by the EvaluationEngine.
	/// </summary>
	public interface IFunction : IFunctionParameter
	{
		/// <summary>
		/// The id of the function, used only for notification.
		/// </summary>
		string Id{ get; }

		/// <summary>
		/// Method called by the EvaluationEngine to evaluate the function.
		/// </summary>
		/// <param name="context">The Evaluation context information.</param>
		/// <param name="args">The IFuctionParameters that will be used as arguments to the function.</param>
		/// <returns></returns>
		rtm.EvaluationValue Evaluate( rtm.EvaluationContext context, params IFunctionParameter[] args );

		/// <summary>
		/// Defines the data type returned by the function.
		/// </summary>
		IDataType Returns{ get; }

		/// <summary>
		/// Defines the data types for the function arguments.
		/// </summary>
		IDataType[] Arguments{ get; }

		/// <summary>
		/// Whether the function defines variable arguments. The data type of the variable arguments will be the 
		/// data type of the last parameter.
		/// </summary>
		bool VarArgs{ get; }
	}
}
